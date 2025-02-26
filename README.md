<p align="center">
  <a href="https://smartbills.io/?utm_source=github&utm_medium=logo" target="_blank">
    <!-- <img src="https://smartbills-brand.storage.googleapis.com/smartbills-wordmark-dark-280x84.png" alt="smartbills" width="280" height="84"> -->
  </a>
</p>

Smartbills is on a mission to help developers build the best financial tools. If you want to join us
[<kbd>**Check out our open positions**</kbd>](https://smartbills.io/careers/)

[![Build Status](https://img.shields.io/github/actions/workflow/status/smartbills/smartbills-dotnet/build.yml)](https://github.com/smartbills/smartbills-dotnet/actions)

# Smartbills .NET SDK
This is the .NET SDK for Smartbills. It allows you to interact with the Smartbills API from your .NET application.

## Links

- [![Documentation](https://img.shields.io/badge/documentation-smartbills.io-green.svg)](https://docs.smartbills.io/)
- [![Stack Overflow](https://img.shields.io/badge/stack%20overflow-smartbills-green.svg)](http://stackoverflow.com/questions/tagged/smartbills)
- [![Twitter Follow](https://img.shields.io/twitter/follow/SmartbillsApp?label=SmartbillsApp&style=social)](https://twitter.com/intent/follow?screen_name=SmartbillsApp)

## Contents

- [Contributing](https://github.com/smartbills/smartbills-dotnet/blob/main/CONTRIBUTING.md)
- [Supported Platforms](#supported-platforms)
- [Installation and Usage](#installation-and-usage)
- [Other Packages](#other-packages)

## Supported Platforms

This SDK project is built using .NET Standard and .NET Core and supports the following platforms:
- .NET Standard 2.1+
- .NET Core 8.0+

## Installation and Usage
To build and run the project, follow these steps:

```sh
dotnet build
dotnet run --project Smartbills.SDK
```

## Example Usage

Here is an example of how to use the SDK:

```csharp
using Smartbills.SDK;

var client = new SBClient("client_id", "client_secret");

var receipt = await client.Receipts.GetByIdAsync(1326);
```

## Contributors

Thanks to everyone who contributed to the Smartbills .NET Core SDK!

<a href="https://github.com/smartbills/smartbills-dotnet/graphs/contributors">
  <img src="https://contributors-img.web.app/image?repo=smartbills/smartbills-dotnet" />
</a>

---

## 🔗 **Get in Touch**  
🌐 **Website** - [smartbills.io](https://smartbills.io)<br/>
📧 **Email** - [Contact Us](mailto:info@smartbills.io)<br/>
🔗 **LinkedIn** - [Smartbills](https://www.linkedin.com/company/smartbills)<br/>
🔵 **Facebook** - [Smartbills](https://www.facebook.com/smartbillsapp/)<br/>
📸 **Instagram** - [@smartbills](https://www.instagram.com/smartbills)<br/>
▶️ **YouTube** - [Smartbills Channel](https://www.youtube.com/@SmartbillsApp)
---