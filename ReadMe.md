# Steps to Repro 
1. Run `dotnet restore` on the solution folder
2. In all projects under `src/` run `dotnet-pack -o ../../artifacts`
3. In `test/demo` run 
  - `dotnet restore3` 
  - `dotnet project-tool2-sample`

# Steps to build projectDependencyCommand
1.  Run `dotnet restore` on the solution folder
2. In all projects under `src/` run `dotnet-pack -o ../../artifacts`
3. In `test/demo` run
  - `dotnet restore3`
  - `dotnet build3`
  - `dotnet project-tool-sample abc`