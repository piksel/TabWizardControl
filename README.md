# TabWizardControl

Simple wizard control for .NET WinForms that extends a TabControl for this purpose.

Design-time:  
![](https://i.imgur.com/FL02jmO.png)

Runtime:  
![](https://i.imgur.com/7vcYv4W.png)

Behaviour controlled by lambdas:  
```.cs
    // Move to Bar if checked, move to Baz if checked, otherwise disable Next button
    wizard.NextFunction(tpFoo, () => rbBar.Checked ? tpBar : rbBaz.Checked ? tpBaz : null);

    // Link Previous button for Baz panel to Foo (skipping Bar)
    wizard.PreviousFunction(tpBaz, tpFoo);
    
    // Enable the Next button for Baz if a value from the combobox has been selected
    wizard.NextFunction(tpBaz, () => comboBox1.SelectedIndex >= 0);
```
