# SteamCSS
Insert custom CSS to Steam Library and Browser.

## Usage
Download `SteamCSS.zip` at [Releases](https://github.com/the1812/SteamCSS/releases) page.

There are 3 files:
- `SteamCSS.exe`: Main program
- `SteamPath.txt`: Specify Steam install path
- `Style.css`: Your custom CSS code to insert

Write your Steam install path in `SteamPath.txt` and custom CSS code in `Style.css`.

Start `SteamCSS.exe`, it will insert CSS code into Steam files and exit silently.

## Notes
- The default `font-family` is from [Sarasa-Gothic](https://github.com/be5invis/Sarasa-Gothic).
- This only applies on library and built-in browser, you may need [MacType](https://github.com/snowie2000/mactype) to change Steam UI font.
- Steam files will be overwritten after some Steam updates, and you have to rerun this program to insert CSS again.
