﻿using System.ComponentModel.DataAnnotations;

namespace DesignPatterns.Structural.Facade.CrossCutting
{
    public interface IConfigurationManager
    {
        string GetValue(string key);
    }
}