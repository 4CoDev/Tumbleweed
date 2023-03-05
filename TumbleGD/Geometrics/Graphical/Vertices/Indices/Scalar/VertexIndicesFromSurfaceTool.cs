using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;
using Array = Godot.Collections.Array;

namespace TumbleGD.Geometrics.Graphical.Vertices.Indices.Scalar;

public sealed class VertexIndicesFromSurfaceTool
	: IScalar<IEnumerable<IScalar<Int32>>>
{
	public VertexIndicesFromSurfaceTool(IScalar<SurfaceTool> surfaceTool)
	{
		this.surfaceTool = surfaceTool;
	}

	public IEnumerable<IScalar<Int32>> Value
	{
		get
		{
			Array surfaceAsArrays = surfaceTool.Value.CommitToArrays();
			const Int32 indexArrayType = (Int32) Mesh.ArrayType.Index;
			Int32[] indicesAsValues = surfaceAsArrays[indexArrayType].AsInt32Array();
			return new ScalarsOfValues<Int32>(indicesAsValues);
		}
	}

	private readonly IScalar<SurfaceTool> surfaceTool;
}