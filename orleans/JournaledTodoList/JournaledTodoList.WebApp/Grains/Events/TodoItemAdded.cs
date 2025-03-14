﻿namespace JournaledTodoList.WebApp.Grains.Events;

[GenerateSerializer, Immutable]
public record class TodoItemAdded(int ItemId, DateTimeOffset Timestamp, string Title)
    : TodoListEvent(ItemId, Timestamp)
{
    public override string GetDescription() => $"Added item {ItemId}: {Title}";
}
