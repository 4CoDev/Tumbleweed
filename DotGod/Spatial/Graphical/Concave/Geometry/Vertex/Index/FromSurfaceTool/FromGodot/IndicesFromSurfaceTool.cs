using DotGod.Spatial.Graphical.Concave.Geometry._Mesh.ArrayType;
using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using GodotArray = Godot.Collections.Array;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex.Index.FromSurfaceTool.
	FromGodot;

public sealed class IndicesFromSurfaceTool : Tumbleweed.Enumerable.Envelope<Int32>
{
	public IndicesFromSurfaceTool(Any<SurfaceTool> tool) : base
	(
		new Result<Int32>(
			() => Function(tool))
	)
	{
	}

	private static IEnumerable<Int32> Function(Any<SurfaceTool> tool)
	{
		GodotArray arrays = tool.Value.CommitToArrays();
		Int32 indexArrayType = new IndexArray().Value;
		Int32[] indices = arrays[indexArrayType].AsInt32Array();
		return indices;
	}
}