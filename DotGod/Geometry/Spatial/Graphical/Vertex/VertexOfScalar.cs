using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Vertex;

public sealed class VertexOfScalar : IVertex
{
	public VertexOfScalar(IScalar<IVertex> scalar)
	{
		this.scalar = scalar;
	}
	
	public IPoint<IReal> Translation => scalar.Value.Translation;

	public IPoint<IReal> Normal => scalar.Value.Normal;

	public IScalar<Color> Color => scalar.Value.Color;

	public Tumbleweed.Point.Planar.IPoint<IReal> UV => scalar.Value.UV;

	private readonly IScalar<IVertex> scalar;
}