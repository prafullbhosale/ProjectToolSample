# Steps to Repro 
1. Run `dotnet restore` on the solution folder
2. In `src/ProjectToolSample` and `src/dotnet-project-tool2-sample` run `dotnet-pack -o ../../artifacts`
3. In `test/demo` run 
  - `dotnet restore3` 
  - `dotnet project-tool-sample`
  - `dotnet project-tool2-sample`
