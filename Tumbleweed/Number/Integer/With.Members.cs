// ReSharper disable once CheckNamespace

using Tumbleweed.Boolean.From.System;

namespace Tumbleweed.Number.Integer.With;

public sealed class Members : Integer.Any
{
	public Members
	(
		global::System.Boolean isPositive,
		Natural.Any natural
	) : this
	(
		new One(isPositive),
		natural
	)
	{
	}
	
	public Members
	(
		Boolean.Any isPositive,
		Natural.Any natural
	)
	{
		IsPositive = isPositive;
		Natural = natural;
	}
	
	public Boolean.Any IsPositive { get; }
	
	public Natural.Any Natural { get; }
}