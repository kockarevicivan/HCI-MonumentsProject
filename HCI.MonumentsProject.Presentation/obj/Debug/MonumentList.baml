   M S B A M L   `   `   `  ����\  XHCI.MonumentsProject.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:HCI.MonumentsProject.Presentation.HelpFiles+HCI.MonumentsProject.Presentation.HelpFiles  5   	   U/clr-namespace:HCI.MonumentsProject.Presentation!HCI.MonumentsProject.Presentation  5   	   4    .HCI.MonumentsProject.Presentation.MonumentList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Gl9clr-namespace:HCI.MonumentsProject.Presentation.HelpFiles     5   	   Alocal/clr-namespace:HCI.MonumentsProject.Presentation     5   	     � Title$  Kompletna lista spomenika��5	   
   $��487.928��6,   $	��850��6=    � 
ResizeMode$ NoResize=�6I   >   8HCI.MonumentsProject.Presentation.HelpFiles.HelpProvider   HelpKey$ index��6_    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Help��5      6<   .��5      �  � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $��8* �6   �� 5      $��1* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ monumentsGrid��5   >   $��10,10,10,10q�6U      
IsReadOnly . 	   AutoGenerateColumns	 .  
 � DataContext
 6   ��  �� Source$ 	monuments��   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 Id:��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Id+  5      $
 Ime:��6%    63   �� *Name+  5      $ Opis:��6%    64   �� *Description+  5      $
 Tip:��6%    63   �� *MonumentType.Name+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Ikonica:��6)      CanUserResize .     CellTemplate 5      �� 5      .R�5      �� $��40��6@   ��6$   �� *
IconPath+6@   5      5!        5"      $ Arheološki obrađen:��6%    6B   �� *IsArchaeologicallyProcessed+  5#      $ Na listi UNESCO:��6%    6?   �� *IsOnUNESCOList+  5$      $ U naseljenom mestu:��6%    6B   �� *IsInPopulatedArea+  5%      $ Turistički status:��6%    6A   �� *TouristStatus+  5&      $ Godišnji prihod:��6%    6?   �� *
YearIncome+  5'      $ Datum otkrivanja:��6%    6@   �� *DateOfDiscovery+5)      �� 5*   
   -   5         ��Name$ 
backButton��5*      $��1��6   $��Nazad��62   $��762,0,10,10q�6B   $��60��6W   6b   �� 5+   
   -   5        $ removeButton��5+      $��1��6   $��Izbriši��64   $��60��6G   $��697,0,75,10q�6R   6g   �� 5,   
   -   5        $ updateButton��5,      $��1��6   $��Uredi��64   $��60��6E   $��632,0,140,10q�6P   6f   �� 5-   
   -   5        $ createButton��5-      $��1��6   $��Kreiraj��64   $��60��6G   $��567,0,205,10q�6R   6h   �� 5.   
   -   5         ��Name$ 	searchBar��5.       �� TextWrapping$
 Wrap=�6%   $
��Left=�69   $��41��6T   $��	320,0,0,0q�6`   $��1��6s   $	��Top=�6�   $	��172��6�    �� AcceptsReturn . 6�   �� 5/   
   -   5        $ searchButton��5/      $��1��6   $��	Filtriraj��64   $��497,0,276,10q�6H   6^   50      51      