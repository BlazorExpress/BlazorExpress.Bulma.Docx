# BlazorExpress.Bulma.Docx v0.3.0 - Release Summary

**Version:** 0.3.0  
**Release Date:** August 20, 2025  
**Previous Version:** 0.2.2

## 🎯 Key Changes Summary

### Enhanced Component Parameter Documentation
- Modified `TypeExtensions.GetComponentParameters()` to include ALL properties with `ParameterAttribute`
- Previously excluded `AdditionalAttributes` and other system parameters are now included
- Provides more complete API documentation coverage for Blazor components

### UI/UX Improvements  
- Simplified clipboard feedback in `CodeChunk` and `Demo` components
- Disabled tooltip text updates to prevent unnecessary UI refreshes
- Maintained visual feedback through icon changes only

### Code Quality & Maintenance
- Removed 42 lines of unused `StringConstants` class
- Cleaned up unnecessary imports (`Microsoft.VisualBasic.FileIO`)
- Commented out unused private fields in components

### Documentation Updates
- Updated README.md installation instructions from v0.1.0 to v0.3.0
- Updated package references in project documentation

## ⚠️ Breaking Changes
The component parameter documentation now includes previously excluded system parameters like `AdditionalAttributes`. This affects tools that consume the `GetComponentParameters()` method output.

## 📦 Quick Install
```bash
dotnet add package BlazorExpress.Bulma.Docx --version 0.3.0
```

## 📊 Release Stats
- **3 commits** with focused improvements
- **5 files** modified
- **Net -44 lines** (cleanup focused release)
- **0 new dependencies**

## 🔗 Links
- [Compare Changes](https://github.com/BlazorExpress/BlazorExpress.Bulma.Docx/compare/v0.2.2...v0.3.0)
- [Full Release Notes](./RELEASE-NOTES-v0.3.0.md)
- [GitHub Release Notes](./GITHUB-RELEASE-NOTES-v0.3.0.md)

---
*This release focuses on improving documentation completeness and simplifying the user experience while maintaining backward compatibility.*