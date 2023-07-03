# SteamCSS
向 Steam 库和内置浏览器插入自定义 CSS 代码.

[English](./README.md)

## 使用方式
从 [Releases](https://github.com/the1812/SteamCSS/releases) 页面下载 `SteamCSS.zip`.

解压后有 4 个文件:
- `SteamCSS.exe`: 主程序
- `SteamPath.txt`: 指定 Steam 安装文件夹
- `StylePath.txt`: 指定向哪些文件插入样式
- `Style.css`: 自定义要插入的 CSS 代码

先在 `SteamPath.txt` 里写下 Steam 的安装文件夹,  `Style.css` 里写下要插入的 CSS 代码.
另外也可以再新建一个 `BrowserStyle.css` 文件, 这个样式可以替代 `Style.css` 插入到 Steam 内置浏览器的样式中.

然后启动 `SteamCSS.exe` 就可以了.

## 注意事项
- 默认的 `font-family` 是 [Sarasa-Gothic](https://github.com/be5invis/Sarasa-Gothic).
- 只对库和内置浏览器生效, 其他地方的 UI 字体可以用 [MacType](https://github.com/snowie2000/mactype) 替换.
- Steam 更新后可能会覆盖掉样式, 需要再运行一下这个工具重新写入.
