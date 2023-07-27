using Tumbleweed.Number.Integer.System.Medium.From;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Lazy;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh.ArrayType;

public sealed class IndexArray : Envelope<Int32>
{
	public IndexArray() : base
	(
		new OfValue<Int32>(
			new Long(
				new Tumbleweed.Object.Unpacked<Int64>(
					Godot.Mesh.ArrayType.Index)))
	)
	{
	}
}