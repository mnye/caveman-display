# caveman-display
Caveman Display - A WYSIWYG UI editor for microcontroller displays

Written in C#
If I was better with the web I'd make a browser version, but the priority for now is to get something working, not to learn a new technology

Designed around using an ESP32, C++, and a Sharp MemoryLCD display
- https://www.adafruit.com/product/4694

Shouldn't be hard to expand to support other displays, languages

Goals:
- Point & click interface to draw graphics
- Define const & variable sections of the screen to know what needs to be refreshed
- Define variables linked to parts of the screen (e.g., text) which allows for trivial changes

Lofty goals?
- Animations
