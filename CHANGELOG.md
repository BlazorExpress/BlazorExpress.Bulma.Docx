# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [0.3.0] - 2025-01-21

### What's New

- **Initial Release**: First public release of BlazorExpress.Bulma.Docx library
- **Documentation Components**: Complete set of components for creating component library documentation
  - `Demo` - Interactive component demonstration with code viewing and clipboard functionality
  - `CodeChunk` - Standalone code snippets with syntax highlighting and copy-to-clipboard
  - `DocxTable` - Dynamic documentation tables for component parameters, properties, methods, and events
  - `Section` - Documentation sections with anchor links
  - `PageHero` - Hero sections for documentation pages
  - `PageMetaTags` - SEO-friendly meta tags for documentation pages
  - `WebsiteNavbar` - Navigation bar component for documentation sites
- **Table Components**: Specialized row components for different documentation types
  - `DocxPropertyRow` - Display component properties and parameters
  - `DocxMethodRow` - Display component methods with descriptions
  - `DocxEventCallbackRow` - Display component event callbacks
- **Navigation Components**:
  - `DocsLink` - Links to documentation pages
  - `DemoLink` - Links to demo pages
  - `StarOnGitHub` - GitHub star button component
  - `DoYouKnow` - Information callout component
- **Multi-Framework Support**: Targets both .NET 8.0 and .NET 9.0
- **Language Support**: Comprehensive syntax highlighting support for multiple languages via PrismJS integration
- **JavaScript Interop**: Copy-to-clipboard functionality with visual feedback

### What's Changed

- Built on top of BlazorExpress.Bulma v0.1.1 for consistent Bulma CSS styling
- Comprehensive reflection-based documentation generation using custom extension methods
- Support for version tracking with `AddedVersionAttribute` integration
- Responsive design with mobile-friendly navigation and layout
- SEO optimization with meta tags for social media sharing (Twitter, Facebook)

### Other Updates

- **Dependencies**: 
  - BlazorExpress.Bulma v0.1.1
  - Microsoft.AspNetCore.Components.Web v8.0.17 (for .NET 8.0)
  - Microsoft.AspNetCore.Components.Web v9.0.0 (for .NET 9.0)
  - Microsoft.Extensions.Configuration.Abstractions v8.0.0/.NET 9.0.0
- **Development**: 
  - Apache-2.0 license
  - Support for browser platform targeting
  - Embedded resources for JavaScript interop functionality
- **Enums and Types**:
  - `DocType` - Documentation table types (Parameters, Properties, Methods, Events)
  - `LanguageCode` - Supported programming languages for syntax highlighting
  - `PageLinkCategory` - Page link categorization
  - `PageLinkStatus` - Page link status tracking
- **Extensions**: Rich set of reflection extension methods for documentation generation
  - Type extensions for component analysis
  - Property extensions for parameter documentation
  - Method extensions for API documentation

[0.3.0]: https://github.com/BlazorExpress/BlazorExpress.Bulma.Docx/releases/tag/v0.3.0