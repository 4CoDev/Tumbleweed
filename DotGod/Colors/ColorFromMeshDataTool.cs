using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Colors;

public sealed class ColorFromMeshDataTool : IScalar<Color>
{
	public ColorFromMeshDataTool
	(
		IScalar<MeshDataTool> meshDataTool,
		IScalar<Int32> vertex
	)
	{
		this.meshDataTool = meshDataTool;
		this.vertex = vertex;
	}

	public Color Value => meshDataTool.Value.GetVertexColor(vertex.Value);

	private readonly IScalar<MeshDataTool> meshDataTool;
	
	private readonly IScalar<Int32> vertex;
}