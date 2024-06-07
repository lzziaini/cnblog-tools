using Common.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Html2Markdown;

namespace CnblogsToMarkdown
{

    public class CnblogHtmlHelper
    {

        public const string mCodeblockBegin = "{% codeblock lang:csharp%}";
        public const string mCodeblockEnd = "{% endcodeblock %}";
        /// <summary>
        /// 导出博客园的文章成本地 Markdown 进行保存
        /// </summary>
        /// <param name="accountname">博客账户名</param>
        /// <param name="pageStart">博客起始页码，即 http://www.cnblogs.com/q787011187/default.html?page={0} </param>
        /// <param name="pageEnd">博客结束页码，即 http://www.cnblogs.com/q787011187/default.html?page={0} </param>
        /// <param name="isSaveImage">是否将文章中的图片保存到本地，保存后文件夹在程序运行的 images 文件夹</param>
        /// <param name="imagePrefixUrl">替换文章中的图片为自己图床的前缀 Url</param>
        /// <param name="isAddMoreSeparateLine">在抓取到的文章 separateLineLocation（参数） 处添加<!--more-->分隔符，用于博客展示文章时用于抽取描述以及阅读更多使用。</param>
        /// <param name="separateLineLocation">添加分隔符的位置</param>
        /// <returns>是否执行完成</returns>
        public static bool ExportToMarkdown(string accountname, int pageStart, int pageEnd, bool isSaveImage, string imagePrefixUrl = "", bool isAddMoreSeparateLine = false, int separateLineLocation = 300)
        {
            for (var page = pageStart; page <= pageEnd; page++)
            {
                try
                {
                    var pagesUrl = string.Format("http://www.cnblogs.com/" + accountname + "/default.html?page={0}", page);
                    //抓取所有的文章内容链接地址，进行循环抓取并存储
                    var regex = new Regex(@"class=""postTitle"".*?\s+<a.*?href=""(?<href>.*?)"">",
                        RegexOptions.Singleline | RegexOptions.Multiline);
                    var matches = regex.Matches(NetworkHelper.GetHtmlFromGet(pagesUrl, Encoding.UTF8));
                    foreach (Match match in matches)
                    {
                        var articleUrl = match.Groups["href"].ToString();
                        var articleId = articleUrl.Substring(articleUrl.LastIndexOf("/") + 1, 8);
                        var content = NetworkHelper.GetHtmlFromGet(articleUrl, Encoding.UTF8);


                        var htmlDoc = new HtmlDocument();
                        htmlDoc.LoadHtml(content);

                        // 提取appName
                        var appNameNode = htmlDoc.DocumentNode.SelectSingleNode("//script[contains(text(), 'currentBlogApp')]");
                        var appName = appNameNode.InnerText.Split(new[] { "currentBlogApp = '" }, StringSplitOptions.None)[1].Split('\'')[0];

                        // 提取Title
                        var titleNode = htmlDoc.DocumentNode.SelectSingleNode("//a[@id='cb_post_title_url']");
                        var title = titleNode.InnerText.Trim();

                        // 提取articlecontent
                        var articleContentNode = htmlDoc.DocumentNode.SelectSingleNode("//div[@id='cnblogs_post_body']");
                        var articleContent = articleContentNode.InnerText.Trim();

                        // 提取date
                        var dateNode = htmlDoc.DocumentNode.SelectSingleNode("//span[@id='post-date']");
                        var date = dateNode.InnerText.Trim();

                        // 定位包含变量的<script>节点
                        var scriptNode = htmlDoc.DocumentNode.SelectSingleNode("//script[contains(text(), 'cb_blogApp')]");
                        if (scriptNode == null) return false;
                        var script = scriptNode.InnerText;

                        // 使用正则表达式提取变量值
                        var cbEntryId = Regex.Match(script, @"cb_entryId = (\d+),").Groups[1].Value;
                        var cbEntryCreatedDate = Regex.Match(script, @"cb_entryCreatedDate = '([^']+)").Groups[1].Value;
                        var cbPostType = Regex.Match(script, @"cb_postType = (\d+),").Groups[1].Value;
                        var cbPostTitle = Regex.Match(script, @"cb_postTitle = '([^']+)").Groups[1].Value;
                        var allowComments = Regex.Match(script, @"allowComments = (\w+),").Groups[1].Value;
                        var cbBlogId = Regex.Match(script, @"cb_blogId = (\d+),").Groups[1].Value;
                        var cbBlogApp = Regex.Match(script, @"cb_blogApp = '([^']+)").Groups[1].Value;
                        var cbBlogUserGuid = Regex.Match(script, @"cb_blogUserGuid = '([^']+)").Groups[1].Value;

                        // 打印提取的值
                        //Console.WriteLine("cb_entryId: " + cbEntryId);
                        //Console.WriteLine("cb_entryCreatedDate: " + cbEntryCreatedDate);
                        //Console.WriteLine("cb_postType: " + cbPostType);
                        //Console.WriteLine("cb_postTitle: " + cbPostTitle);
                        //Console.WriteLine("allowComments: " + allowComments);
                        //Console.WriteLine("cb_blogId: " + cbBlogId);
                        //Console.WriteLine("cb_blogApp: " + cbBlogApp);
                        //Console.WriteLine("cb_blogUserGuid: " + cbBlogUserGuid);


                        if (isSaveImage)
                        {
                            articleContent = ProcessArticleImage(articleContent, articleId, imagePrefixUrl); //对文章中的图片进行保存，根据情况可以不处理，如何有自己的图床，那么保存下来后替换掉图床前缀就可以了。
                        }


                        articleContent = ProcessArticleCode(articleContent);
                        articleContent = articleContent.Replace("<div class=\"cnblogs_Highlighter\">", "```")
                            .Replace("</pre>", "```"); //博客标记的特殊处理

                        int blogId = 0, postId = 0;
                        blogId = int.Parse(cbBlogId);
                        postId = int.Parse(cbEntryId);

                        var fileName = GetFileName(title, date);
                        var filePath = System.Windows.Forms.Application.StartupPath + "\\output\\" + fileName;
                        var mdContent = $"---\r\ntitle: {title}\r\ndate: {date}\r\n\r\n---\r\n{articleContent}";
                        var converter = new Converter();
                        var markdown = converter.Convert(mdContent);
                        int tmpseparateLineLocation = separateLineLocation;
                        //注意此处的作用是在抓取到的文章 300 字符处添加<!--more-->分隔符，用于博客展示文章时用于抽取描述以及阅读更多使用。                       
                        if (isAddMoreSeparateLine && markdown.Length > (separateLineLocation + 1))
                        {
                            int indexb = 0, indexe = 0;
                            while (indexe < separateLineLocation)
                            {
                                indexb = markdown.IndexOf(mCodeblockBegin, indexe);
                                if (indexb == -1)
                                {
                                    break;//there are no codes in the arcticle.
                                }
                                indexe = markdown.IndexOf(mCodeblockEnd, indexb);
                                //if the code block is truncated,adjust the separateLineLocation
                                if ((indexb <= separateLineLocation && separateLineLocation <= indexb + mCodeblockBegin.Length)
                                    || (indexe <= separateLineLocation && separateLineLocation <= indexe + mCodeblockEnd.Length))
                                {
                                    separateLineLocation = indexe + mCodeblockEnd.Length;
                                    break;
                                }
                            }
                            markdown = markdown.Substring(0, separateLineLocation) + "\r\n<!--more-->\r\n" +
                                       markdown.Substring(separateLineLocation + 1);
                            separateLineLocation = tmpseparateLineLocation;
                        }
                        markdown = markdown.Replace("{% codeblock lang:csharp%}", "```")
                            .Replace("{% endcodeblock %}", "```");
                        var streamWriter = new StreamWriter(filePath);
                        streamWriter.Write(markdown);
                        streamWriter.Close();
                        Console.WriteLine(fileName + " have been generated..");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return true;
        }


        #region 元素抓取
        private static string GetFileName(string articleUrl)
        {
            if (articleUrl.Length > articleUrl.LastIndexOf("/") + 1)
                return articleUrl.Substring(articleUrl.LastIndexOf("/") + 1).Replace(".html", string.Empty) + ".md";
            return "path_error";
        }
        private static string GetFileName(string title, string date)
        {
            var fileName = title + ".md";
            Regex regex = new Regex("[:|\\|/|*|?|>|<||]");
            fileName = regex.Replace(fileName, "-");
            return fileName;
        }

        private static string GetArticleCategory(string appName, int blogId, int postId)
        {
            var strReturn = string.Empty;
            var apiReturn =
                NetworkHelper.GetHtmlFromGet(string.Format("http://www.cnblogs.com/mvc/blog/CategoriesTags.aspx?blogApp={0}&blogId={1}&postId={2}", appName, blogId, postId), Encoding.UTF8);
            var content = StringHelper.ConvertUnicode(apiReturn); //注意参数 appName 需要替换，其实blogid不要获取，是固定的。
            var regexCategory = new Regex(@".*?category.*?>(\d+\.)?(?<cata>.*?)</a>",
                RegexOptions.Singleline | RegexOptions.Multiline);
            var regexTag = new Regex(".*?tag.*?>(?<cata>.*?)</a>", RegexOptions.Singleline | RegexOptions.Multiline);
            var matches = regexCategory.Matches(content);
            var stringBuilder = new StringBuilder();
            foreach (Match match in matches)
            {
                var catName = match.Groups["cata"].ToString();
                if (catName == "Sugars") //一些分类的替换，可根据需要修改
                {
                    catName = "开发技巧";
                }
                stringBuilder.AppendFormat("\r\n- {0}", catName);
            }
            if (matches.Count > 0)
            {
                strReturn = "categories:" + stringBuilder;
            }

            var stringBuilderTags = new StringBuilder();
            var matchesTag = regexTag.Matches(content);
            foreach (Match match in matchesTag)
            {
                var catName = match.Groups["cata"].ToString();
                stringBuilderTags.AppendFormat("{0},", catName);
            }
            if (!string.IsNullOrEmpty(strReturn))
            {
                strReturn += "\r\n";
            }
            if (matchesTag.Count > 0)
            {
                strReturn += "tags: [" + stringBuilderTags.ToString().Trim(',') + "]"; //导入的文章添加了默认的 tag，可去除。
            }
            return strReturn;
        }

        private static string ProcessArticleImage(string articleContent, string articalId, string imagePrefixUrl = "")
        {
            var regex = new Regex(@"<img\s+src=""(?<src>.*?)""", RegexOptions.Singleline | RegexOptions.Multiline);
            var matches = regex.Matches(articleContent);
            var preImagePath = "";
            var i = 1;
            foreach (Match match in matches)
            {
                var imagePath = match.Groups["src"].ToString();
                var suffix = imagePath.Substring(imagePath.Length - 4);
                if (".gif.jpg.png.GIF.JPG.PNG".IndexOf(suffix) == -1)
                {
                    suffix = ".jpg";
                }
                var imageName = articalId + "_" + (i++) + suffix;

                if (string.IsNullOrEmpty(preImagePath))
                {
                    preImagePath = imagePath.Substring(0, imagePath.LastIndexOf("/") + 1);
                }
                NetworkHelper.SavePhotoFromUrl(System.Windows.Forms.Application.StartupPath + "\\images\\" + imageName, imagePath);

                articleContent = articleContent.Replace(imagePath, imagePrefixUrl + imageName); //自己的图床前缀
            }

            return articleContent;
        }

        private static string ProcessArticleCode(string articleContent)
        {
            var regex =
                new Regex(
                    @"(?<total><div\s+class=""cnblogs_code"">.*?(<pre>|<div>)(?<code>.*?)(</pre>|</div>).*?</div>)",
                    RegexOptions.Singleline | RegexOptions.Multiline);
            var matches = regex.Matches(articleContent);
            foreach (Match match in matches)
            {
                var resultString = Regex.Replace(match.Groups["code"].ToString(),
                    @"<span\s+style=""color:\s+#008080;"">\s*\d+\s*", "",
                    RegexOptions.Singleline | RegexOptions.Multiline);
                resultString = Regex.Replace(resultString, "<span.*?>", "",
                    RegexOptions.Singleline | RegexOptions.Multiline);
                resultString = Regex.Replace(resultString, "</span>", "",
                    RegexOptions.Singleline | RegexOptions.Multiline);

                resultString = "\r\n" + mCodeblockBegin + "\r\n" + resultString + "\r\n" + mCodeblockEnd + "\r\n";
                articleContent = articleContent.Replace(match.Groups["total"].ToString(), resultString);

            }
            return articleContent.Replace("<div class=\"cnblogs_code\">", string.Empty)
                        .Replace("</div>", string.Empty);
        }

        #endregion
    }
}
