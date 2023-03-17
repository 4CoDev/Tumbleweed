using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Meshes;

public sealed class MeshOfFunction : MeshEnvelope
{
	public MeshOfFunction(Func<IMesh> function) : this
	(
		new NullaryFromSystem<IMesh>(function)
	)
	{
	}
	
	public MeshOfFunction(INullaryFunction<IMesh> function) : base
	(
		new MeshOfScalar(
			new ValueOfFunction<IMesh>(function))
	)
	{
	}
}