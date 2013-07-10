# LucidMVC Template

This is a sample project using [LucidMVC](https://github.com/Earlz/lucidmvc). You can use this project as a way to get started making a new website with LucidMVC.

# T4

This has a prebuild step configured to execute `/usr/local/bin/mono-t4`. This file should be something like this:

    #!/bin/bash
    x=$(mono /usr/lib/monodevelop/AddIns/MonoDevelop.TextTemplating/TextTransform.exe -o $1 $2)
    echo $x

Under Windows/Visual Studio I don't currently have a good replacement for this script :( 