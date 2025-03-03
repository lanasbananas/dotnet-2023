﻿using ReactiveUI;
using System.ComponentModel.DataAnnotations;
using System.Reactive;

namespace Factory.Client.ViewModels;
public class TypeIndustryViewModel : ViewModelBase
{

    private int _id;
    public int TypeIndustryID
    {
        get => _id;
        set => this.RaiseAndSetIfChanged(ref _id, value);
    }
    [Required]
    private string _name = string.Empty;
    public string Name
    {
        get => _name;
        set => this.RaiseAndSetIfChanged(ref _name, value);
    }
    public ReactiveCommand<Unit, TypeIndustryViewModel> OnSubmitCommand { get; }
    public TypeIndustryViewModel()
    {
        OnSubmitCommand = ReactiveCommand.Create(() => this);
    }
}
