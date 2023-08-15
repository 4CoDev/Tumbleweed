using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;
using Placement = DotGod.Node.Batch.Entity.Placement;

namespace DotGod.Node.Batch.Entity.Placement.Member;

public sealed class Remove : Procedure::Envelope
{
	public Remove
	(
		Placement::Any placement
	) : base
	(
		new Procedure::From.System(placement.Remove)
	)
	{
	}
}