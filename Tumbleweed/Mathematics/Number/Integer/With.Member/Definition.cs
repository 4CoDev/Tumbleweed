using Tumbleweed.Mathematics.Boolean.From.System;

namespace Tumbleweed.Mathematics.Number.Integer.With.Member;

public sealed class Definition : Any
{
	public Definition
	(
		global::System.Boolean isPositive,
		Mathematics.Number.Natural.Any natural
	) : this
	(
		new One(isPositive),
		natural
	)
	{
	}
	
	public Definition
	(
		Boolean.Any isPositive,
		Mathematics.Number.Natural.Any natural
	)
	{
		IsPositive = isPositive;
		Natural = natural;
	}
	
	public Boolean.Any IsPositive { get; }
	
	public Mathematics.Number.Natural.Any Natural { get; }
}