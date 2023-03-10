using Godot;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Planar;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices;

public sealed class VertexFromScalar : IVertex
{
	public VertexFromScalar(IScalar<IVertex> scalar)
	{
		this.scalar = scalar;
	}
	
	public ISpatial<IFractional> Translation => scalar.Value.Translation;

	public ISpatial<IFractional> Normal => scalar.Value.Normal;

	public IScalar<Color> Color => scalar.Value.Color;

	public IPlanar<IFractional> UV => scalar.Value.UV;

	private readonly IScalar<IVertex> scalar;
}