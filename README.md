# SimpleSpecs
SimpleSpecs - A way to view your systems specs simply.

# How to compile/build
Build using Visual Studio.
If you want to merge the DLLs into the compiled program you can install `ILMerge` and use `ilmerge /target:winexe /out:C:\output.exe C:\input.exe C:\one.dll C:\two.dll`.
For example:
<pre>
ilmerge /target:winexe /out:D:\SimpleSpecs\bin\Release\SimpleSpecs-Dll-Merged.exe D:\SimpleSpecs\bin\Release\SimpleSpecs.exe D:\SimpleSpecs\bin\Release\MetroFramework.dll D:\SimpleSpecs\bin\Release\MetroFramework.Fonts.dll
</pre>

# Images
![](https://i.imgur.com/gaLvjfU.png)
