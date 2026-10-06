List<IInteractable> interactables = new List<IInteractable>
{
    new NPC(),
    new Loot(),
    new Door()
};

foreach (IInteractable interactable in interactables)
{
    interactable.Interact();
}