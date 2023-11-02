using DotGod.Resource.On.Path.From.File;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.ArrayMesh.From.File.On.Path;

public sealed class One : Envelope<Godot.ArrayMesh>
{
	public One(String path) : this
	(
		new One<String>(path)
	)
	{
	}
	
	public One(Any<String> path) : base
	(
		new Actual<Godot.ArrayMesh>(path)
	)
	{
	}
}
