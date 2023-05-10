using Godot;
using Tumbleweed.Numbers.Integers.Signed.OfSystem.Ints32;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Meshes.ArrayTypes;

public sealed class IndexArray : ScalarEnvelope<Int32>
{
	public IndexArray() : base
	(
		new LazyValue<Int32>(
			new Int32From64(
				new ObjectAsType<Int64>(
					Mesh.ArrayType.Index)))
	)
	{
	}
}