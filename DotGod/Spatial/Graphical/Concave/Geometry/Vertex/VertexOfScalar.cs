using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Scalar;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex;

public sealed class VertexOfScalar : IVertex
{
	public VertexOfScalar(IScalar<IVertex> scalar)
	{
		this.scalar = scalar;
	}
	
	public IPoint<IReal> Translation => scalar.Value.Translation;

	public IPoint<IReal> Normal => scalar.Value.Normal;

	public IScalar<Color> Color => scalar.Value.Color;

	public Tumbleweed.Planar.Point.IPoint<IReal> UV => scalar.Value.UV;

	private readonly IScalar<IVertex> scalar;
}