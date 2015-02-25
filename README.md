hunt-n-peck
===========
Simple vimium/vimperator style navigation for Windows applications based on the UI Automation framework. In essence, it works the same as screen readers or accessibility programs but with the goal of making any Windows program faster to use.

It works for any Windows program (excluding Modern UI apps :))

![ScreenShot](https://raw.github.com/zsims/hunt-n-peck/master/screenshots/explorer.png)
![ScreenShot](https://raw.github.com/zsims/hunt-n-peck/master/screenshots/visual-studio.png)

To use
------------------

1. Launch the executable.
2. With any window focused, press Alt + ;
3. An overlay window will be displayed, type any of the hint characters you see.


Supported Elements
------------------
Only UI Automation elements with "Invoke" patterns are supported (and displayed).

TODO
------------------
Some things on the "roadmap":

1. The ability to customize options, including the hotkey and hint characters.
3. More UI Automation patterns, such as scroll or expand/collapse.
4. "Debug" mode that displays all hints regardless of supported patterns.
