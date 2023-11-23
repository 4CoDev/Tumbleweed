using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;
using System = System;

namespace Tumbleweed.Enumerable.Lazy;

public sealed class Selected<T> : Enumerable::Envelope<T>
{
	public Selected
	(
		SCG::IEnumerable<T> enumerable,
		System::Func<T, T> expression
	) : base
	(
		new Enumerable::Lazy.Selected<T, T>(
			enumerable,
			expression)
	)
	{
	}
}