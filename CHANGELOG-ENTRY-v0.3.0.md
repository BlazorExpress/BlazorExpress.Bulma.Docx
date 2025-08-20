# Changelog Entry for v0.3.0

## [0.3.0] - 2025-08-20

### Added
- Complete component parameter documentation including system parameters
- Enhanced API documentation coverage for all Blazor components

### Changed  
- **BREAKING**: `TypeExtensions.GetComponentParameters()` now includes `AdditionalAttributes` and other system parameters that were previously excluded
- Simplified clipboard feedback UI in `CodeChunk` and `Demo` components
- Updated package version from 0.2.2 to 0.3.0
- Updated README.md installation instructions to reflect new version

### Removed
- Unused `StringConstants` class from `PropertyInfoExtensions.cs` (42 lines)
- Unnecessary `Microsoft.VisualBasic.FileIO` import from `CodeChunk.razor.cs`
- Tooltip text update functionality in components (simplified to icon changes only)
- Unused private fields: `clipboardTooltipTitle`, `snippetWidth`, `codeSnippetWidth`

### Fixed
- Eliminated unnecessary UI updates during clipboard operations
- Simplified component state management

### Technical Details
- **Files Changed**: 5
- **Lines Added**: 12
- **Lines Removed**: 56  
- **Net Change**: -44 lines
- **Commits**: 3
- **Contributors**: Vikram Reddy (@gvreddy04)

### Migration Notes
- No code changes required for consumers
- Documentation tools may now see additional system parameters in component documentation
- This change provides more complete API documentation coverage

---
*For detailed information, see [RELEASE-NOTES-v0.3.0.md](./RELEASE-NOTES-v0.3.0.md)*