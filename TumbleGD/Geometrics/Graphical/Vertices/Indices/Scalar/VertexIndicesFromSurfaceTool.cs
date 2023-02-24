using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;
using Array = Godot.Collections.Array;

namespace TumbleGD.Geometrics.Graphical.Vertices.Indices.Scalar;

public sealed class VertexIndicesFromSurfaceTool
	: IScalar<IEnumerable<IScalar<int>>>
{
	public VertexIndicesFromSurfaceTool(IScalar<SurfaceTool> surfaceTool)
	{
		this.surfaceTool = surfaceTool;
	}

	public IEnumerable<IScalar<int>> Value
	{
		get
		{
			Array surfaceAsArrays = surfaceTool.Value.CommitToArrays();
			const int indexArrayType = (int) Mesh.ArrayType.Index;
			int[] indicesAsValues = surfaceAsArrays[indexArrayType].AsInt32Array();
			return new ScalarsOfValues<int>(indicesAsValues);
		}
	}

	private readonly IScalar<SurfaceTool> surfaceTool;
}