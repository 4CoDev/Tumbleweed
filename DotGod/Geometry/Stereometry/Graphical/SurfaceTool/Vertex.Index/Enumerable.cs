using DotGod.Geometry.Stereometry.Graphical.Mesh.ArrayType;
using Tumbleweed.Enumerable.Function;
using Tumbleweed.Scalar.Immutable;
using GodotArray = Godot.Collections.Array;

namespace DotGod.Geometry.Stereometry.Graphical.SurfaceTool.Vertex.
	Index;

public sealed class Enumerable : Tumbleweed.Enumerable.Envelope<Int32>
{
	public Enumerable(Any<Godot.SurfaceTool> tool) : base
	(
		new Result<Int32>(
			() => Function(tool))
	)
	{
	}

	private static IEnumerable<Int32> Function(Any<Godot.SurfaceTool> tool)
	{
		GodotArray arrays = tool.Value.CommitToArrays();
		Int32 indexArrayType = new IndexArray().Value;
		Int32[] indices = arrays[indexArrayType].AsInt32Array();
		return indices;
	}
}