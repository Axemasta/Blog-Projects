<div align="center">
    <img src="images\Banner Image.png"</img> 
</div>

The project files for my Barcode Scanning in Xamarin Forms blog post.

[![Language](https://img.shields.io/badge/Language-C%23-brightgreen.svg)]() [![License](https://img.shields.io/github/license/mashape/apistatus.svg)]() [![Release](https://img.shields.io/badge/Release-v1.0-blue.svg)]() [![GitHub issues](https://img.shields.io/github/issues/Axemasta/ScrollingViewExample-XAM.svg)](https://github.com/Axemasta/Barcode-Scanning-MVVM/issues)

This repository contains the source code for my **Barcode Scanning in Xamarin Forms** tutorial, over on my [wordpress site](https://alexduffell.wordpress.com/2018/07/13/barcode-scanning-in-xamarin-forms/).

## Results

Here is the end result of this repo, running on iOS & Android devices!

<div align="center">
    <img src="images\Barcode Scan Devices.png" height="500px"</img> 
</div>

## Nuget Packages

This project uses the following NuGet Packages...

_due to an Android bug with ZXing Mobile 2.4.1, you may find that the android version does not scan. If you encounter this issue, try restoring the NuGet packages and if that fails try downgrading the Zxing.Mobile & Zxing.Mobile.Form packages in the android project to 2.3.2_

| Package                                                      | Purpose                               | Version      |
| ------------------------------------------------------------ | ------------------------------------- | ------------ |
| [Xamarin Forms](https://github.com/xamarin/Xamarin.Forms)    | Xamarin... 😉                          | 3.1.0.583944 |
| [Prism.DryIoc.Forms](https://github.com/PrismLibrary/Prism)  | Dependency Injection Container + More | 7.0.0.396    |
| [Zxing.Mobile](https://github.com/Redth/ZXing.Net.Mobile)    | Barcode Scanning                      | 2.4.1        |
| [Zxing.Mobile.Forms](https://github.com/Redth/ZXing.Net.Mobile) | Barcode Scanning                      | 2.4.1        |



# License

```


​```
Copyright (c) 2018 Axemasta
    
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
    
The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.
    
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.  IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
​```
```
