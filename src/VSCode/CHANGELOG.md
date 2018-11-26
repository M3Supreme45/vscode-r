# Changelog

## 0.0.2 (26 Nov 2018)

### Fixes 

1. Fixes [#2](https://github.com/MikhailArkhipov/vscode-r/issues/2) - `libzip` library may be missing on MacOS preventing R Host from starting. Extension now automates installation of libzip on MacOS via [Homebrew](https://brew.sh/). If /usr/local/opt/libzip/lib/libzip.5.dylib is missing, extension tries to locate Homebrew and install the library by running `brew install libzip`.

2. Fixes [#5](https://github.com/MikhailArkhipov/vscode-r/issues/5) - occasional null reference exception during language server startup.

### Improvements

1. Add support for R Markdown files. R Tools extension is activated when *.rmd file is opened. It automatically associates RMD files with the VS Code markdown editor. Since R Tools extension is active, Ctrl+Enter allows executing R code fragments in the R Markdown files in R Terminal. See also [#3](https://github.com/MikhailArkhipov/vscode-r/issues/3)
