using DotGod.Geometry.Spatial.Graphical.Meshes.ArrayTypes;
using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;
using GodotArray = Godot.Collections.Array;

namespace DotGod.Geometry.Spatial.Graphical.Vertices.Indices.FromSurfaceTools.
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