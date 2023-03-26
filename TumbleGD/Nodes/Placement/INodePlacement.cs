using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Placement;

public interface INodePlacement
{
	void Place(Node parent);

	void Remove();
}