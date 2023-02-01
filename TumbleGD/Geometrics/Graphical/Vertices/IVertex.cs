using Godot;
using Tumbleweed.Measurement.Planars;
using Tumbleweed.Measurement.Spatials;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices;

public interface IVertex
{
	ISpatial<float> Translation { get; }

	ISpatial<float> Normal { get; }
	
	IScalar<Color> Color { get; }
	
	IPlanar<float> UV { get; }
}