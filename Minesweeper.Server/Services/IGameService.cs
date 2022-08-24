﻿using Minesweeper.Server.Entities;
using Minesweeper.Server.Enums;

namespace Minesweeper.Server.Services;

public interface IGameService
{
    Guid StartGame(PlayFieldSize fieldType);

    Field GetField(Guid id, Position position);
    
    PlayField GetPlayField(Guid id);

    List<ClearedField>? OnReveal(Guid id, Field field);
}