using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamCSS
{
  enum TextKeys
  {
    NoFiles,
    Processed,
  }
  class Program
  {
    static readonly Dictionary<string, Dictionary<TextKeys, string>> Texts = new Dictionary<string, Dictionary<TextKeys, string>>
    {
      {"zh-CN", new Dictionary<TextKeys, string>
        {
          { TextKeys.NoFiles, "没有要处理的文件 (已跳过或未找到)" },
          { TextKeys.Processed, "已处理:" },
        }
      },
      {"en-US", new Dictionary<TextKeys, string>
        {
          { TextKeys.NoFiles, "No files to process. (Skipped or not found)" },
          { TextKeys.Processed, "Processed:" },
        }
      },
    };
    [STAThread]
    static void Main()
    {
      try
      {
        var steamPath = File.ReadAllText("SteamPath.txt").Trim();
        var style = File.ReadAllText("Style.css");
        var cssFiles = File.ReadAllText("StylePath.txt").Trim().Split(new string [] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
        var processedFiles = new List<string>();
        cssFiles.ForEach(file =>
        {
          var filePath = Path.Combine(steamPath, file);
          if (!File.Exists(filePath))
          {
            return;
          }
          var content = File.ReadAllText(filePath);
          if (!content.StartsWith(style))
          {
            File.WriteAllText(filePath, style + Environment.NewLine + content);
            processedFiles.Add(filePath);
          }
        });
        var message = string.Join(Environment.NewLine, processedFiles);
        var texts = Texts.TryGetValue(CultureInfo.CurrentUICulture.Name, out var match) ? match : Texts["zh-CN"];
        MessageBox.Show(string.IsNullOrWhiteSpace(message) ? texts[TextKeys.NoFiles] : $"{texts[TextKeys.Processed]}{Environment.NewLine}{message}", "SteamCSS", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (FileNotFoundException ex)
      {
        MessageBox.Show(ex.Message, "SteamCSS", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
