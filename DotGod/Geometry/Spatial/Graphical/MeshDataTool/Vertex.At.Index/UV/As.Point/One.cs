namespace DotGod.Geometry.Spatial.Graphical.MeshDataTool.Vertex.At.Index.UV.As.Point;

public sealed class One : Tumbleweed.Point.Planar.Envelope<Tumbleweed.Number.Real.Any>
{
	public One
	(Tumbleweed.Scalar.Immutable.Any<Godot.MeshDataTool> tool,
		Tumbleweed.Number.Natural.Any vertex
	) : this
	(
		tool,
		new Tumbleweed.Number.Integer.System.Medium.From.Natural.Tumbleweed.One(vertex)
	)
	{
	}
	
	public One
	(Tumbleweed.Scalar.Immutable.Any<Godot.MeshDataTool> tool, Tumbleweed.Scalar.Immutable.Any<Int32> vertex
	) : base
	(
		new DotGod.Point.Planar.From.Vector.One(
			new Vector.One(tool, vertex))
	)
	{
	}
}