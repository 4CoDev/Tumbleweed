using DotGod.Spatial.Graphical.Concave.Geometry._Mesh.ArrayType;
using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;
using GodotArray = Godot.Collections.Array;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex.Index.FromSurfaceTool.
	FromGodot;

public sealed class IndicesFromSurfaceTool : EnumerableEnvelope<Int32>
{
	public IndicesFromSurfaceTool(IScalar<SurfaceTool> tool) : base
	(
		new EnumerableOfFunction<Int32>(
			() => Function(tool))
	)
	{
	}

	private static IEnumerable<Int32> Function(IScalar<SurfaceTool> tool)
	{
		GodotArray arrays = tool.Value.CommitToArrays();
		Int32 indexArrayType = new IndexArray().Value;
		Int32[] indices = arrays[indexArrayType].AsInt32Array();
		return indices;
	}
}