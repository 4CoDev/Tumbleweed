using Godot;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Planar;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices;

public interface IVertex
{
	ISpatial<IFractional> Translation { get; }

	ISpatial<IFractional> Normal { get; }
	
	IScalar<Color> Color { get; }
	
	IPlanar<IFractional> UV { get; }
}