using Tumbleweed.Property.Output;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.MeshDataTool.Vertex.At.Index.Color;

public sealed class One : Any<Godot.Color>
{
	public One
	(
		Any<Godot.MeshDataTool> meshDataTool,
		Any<Int32> vertex
	)
	{
		this.meshDataTool = meshDataTool;
		this.vertex = vertex;
	}

	public Godot.Color Value => meshDataTool.Value.GetVertexColor(vertex.Value);

	private readonly Any<Godot.MeshDataTool> meshDataTool;
	
	private readonly Any<Int32> vertex;
}