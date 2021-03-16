using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamCSS
{
  class Program
  {
    static void Main()
    {
      try
      {
        var steamPath = File.ReadAllText("SteamPath.txt").Trim();
        var style = File.ReadAllText("Style.css");
        var cssFiles = new List<string> { "steamui/css/main.css", "resource/webkit.css" };
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
            File.WriteAllText(filePath, style + "\n" + content); 
          }
        });
      }
      catch (FileNotFoundException ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
