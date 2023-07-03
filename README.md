# SteamCSS
Insert custom CSS to Steam Library and Browser.

[中文](README.zh-CN.md)

## Usage
Download `SteamCSS.zip` at [Releases](https://github.com/the1812/SteamCSS/releases) page.

There are 4 files:
- `SteamCSS.exe`: Main program
- `SteamPath.txt`: Specify Steam install path
- `StylePath.txt`: Specify Steam style files path
- `Style.css`: Your custom CSS code to insert

Write your Steam installation path in `SteamPath.txt` and custom CSS code in `Style.css`.
Optionally, you can create an extra `BrowserStyle.css` file. This style will be inserted to Steam Browser styles in replace of `Style.css`.

Start `SteamCSS.exe` to run the program.

## Notes
- The default `font-family` is from [Sarasa-Gothic](https://github.com/be5invis/Sarasa-Gothic).
- This only applies on library and built-in browser, you may need [MacType](https://github.com/snowie2000/mactype) to change Steam UI font.
- Steam files will be overwritten after some Steam updates, and you have to rerun this program to insert CSS again.
