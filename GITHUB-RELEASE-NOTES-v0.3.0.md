# BlazorExpress.Bulma.Docx v0.3.0 - GitHub Release Notes

## 🎯 What's Changed

### ✨ Enhancements
- **Enhanced Component Parameter Documentation**: Modified `TypeExtensions.GetComponentParameters()` to include ALL properties with `ParameterAttribute`, including system parameters like `AdditionalAttributes`
- **Simplified UI Experience**: Disabled tooltip updates in `CodeChunk` and `Demo` components to prevent unnecessary UI refreshes during clipboard operations
- **Code Cleanup**: Removed 42 lines of unused `StringConstants` class and cleaned up imports

### 🔧 Technical Improvements  
- Updated package version from 0.2.2 to 0.3.0
- Removed unused `Microsoft.VisualBasic.FileIO` import
- Commented out unused tooltip and width tracking fields in components
- Updated README installation instructions to reflect new version

### 📋 Files Changed
- `BlazorExpress.Bulma.Docx.csproj` - Version bump
- `Extensions/TypeExtensions.cs` - Enhanced parameter inclusion  
- `Components/CodeChunk.razor.cs` - UI simplification
- `Components/Demo.razor.cs` - UI simplification
- `Extensions/PropertyInfoExtensions.cs` - Code cleanup (42 lines removed)
- `README.md` - Updated installation instructions

## 🔄 Breaking Changes
⚠️ **Component Parameter Documentation**: The parameter documentation now includes `AdditionalAttributes` and other system parameters that were previously excluded. This provides more complete API documentation but may affect tools that relied on the previous filtering behavior.

## 📦 Installation

```bash
# .NET CLI
dotnet add package BlazorExpress.Bulma.Docx --version 0.3.0
```

```xml
<!-- Package Reference -->
<PackageReference Include="BlazorExpress.Bulma.Docx" Version="0.3.0" />
```

## 📊 Stats
- **3 commits** since v0.2.2
- **5 files** changed  
- **12 additions** and **56 deletions**
- Net **-44 lines** (focused on cleanup)

## 🙏 Contributors
- @gvreddy04 Vikram Reddy

---

**Full Changelog**: https://github.com/BlazorExpress/BlazorExpress.Bulma.Docx/compare/v0.2.2...v0.3.0