using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;

namespace DotGod._Color;

public sealed class ColorFromMeshDataTool : Any<Color>
{
	public ColorFromMeshDataTool
	(
		Any<MeshDataTool> meshDataTool,
		Any<Int32> vertex
	)
	{
		this.meshDataTool = meshDataTool;
		this.vertex = vertex;
	}

	public Color Value => meshDataTool.Value.GetVertexColor(vertex.Value);

	private readonly Any<MeshDataTool> meshDataTool;
	
	private readonly Any<Int32> vertex;
}