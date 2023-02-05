using Godot;
using Tumbleweed.Numerics.Decimals;
using Tumbleweed.Numerics.Planar;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices;

public interface IVertex
{
	ISpatial<IDecimal> Translation { get; }

	ISpatial<IDecimal> Normal { get; }
	
	IScalar<Color> Color { get; }
	
	IPlanar<IDecimal> UV { get; }
}