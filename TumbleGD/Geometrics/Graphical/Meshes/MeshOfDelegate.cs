using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Meshes;

public sealed class MeshOfDelegate : MeshEnvelope
{
	public MeshOfDelegate(INullaryFunction<IMesh> function) : base
	(
		new MeshOfScalar(
			new ValueOfDelegate<IMesh>(function))
	)
	{
	}
}