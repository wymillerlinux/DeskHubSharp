////////////////////
// ARGUMENTS
////////////////////

var target = Argument("Build", "Default");
var configuration = Argument("configuration", "Release");

////////////////////
// TASKS
////////////////////

Task("Build")
.Does(() => {
	MSBuild("../DeskHubSharp.sln");
});

Task("Done")
.IsDependentOn("Build")
.Does(() => {
	Information("Done!");
});

RunTarget(target);