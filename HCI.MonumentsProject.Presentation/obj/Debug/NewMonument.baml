   M S B A M L   `   `   `  ����\  XHCI.MonumentsProject.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:HCI.MonumentsProject.Presentation.HelpFiles+HCI.MonumentsProject.Presentation.HelpFiles  5   	   U/clr-namespace:HCI.MonumentsProject.Presentation!HCI.MonumentsProject.Presentation  5   	   U/clr-namespace:HCI.MonumentsProject.Presentation!HCI.MonumentsProject.Presentation  5   	   3    -HCI.MonumentsProject.Presentation.NewMonument   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Gl9clr-namespace:HCI.MonumentsProject.Presentation.HelpFiles     5   	   Alocal/clr-namespace:HCI.MonumentsProject.Presentation     5   	   ?val/clr-namespace:HCI.MonumentsProject.Presentation     5   	     � Title$  Novi spomenik��5
   	   $	��342��6   $	��670��6,    � 
ResizeMode$ NoResize=�68   >   8HCI.MonumentsProject.Presentation.HelpFiles.HelpProvider   HelpKey$ index��6N    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Help��5      6<   .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $
��1.5* �6   .+�5   
   �� -   5         ��Name$ label��5      $	��Id:��6   $
��Left=�6-   $��	10,10,0,0q�6H   $	��Top=�6[   �� 5   
   -   5        $��	idTextbox��5   L   $��23��6   $
��Left=�6   $��	51,15,0,0q�69   $	��Top=�6]   $��81��6u   �� 5   
   -   5        $ 
label_Copy��5      $��Opis:��6$   $
��Left=�64   $��	10,10,0,0q�6O   $	��Top=�6b    J� RenderTransformOrigin$ 0.969,4.308&�6z   $��1��6�   �� 5   
   -   5        	 ��Name$	 descriptionTextbox��5      $
��Left=�6.   $��23��6I   $��	47,13,0,0q�6U   $��1��6h   
 �� TextWrapping$

 Wrap=�6u   $	��Top=�6�   $	��223��6�   �� 5   
   -   5         ��Name$ eraCombobox��5      $
��Left=�6(   $��
189,14,0,0q�6C   $��2��6W   $	��Top=�6d   $��81��6|   �� 5    
   -   5        $ label1��5       $
��Tip:��6    $
��Left=�6/   $��	13,10,0,0q�6J   $��2��6]   $	��Top=�6j   �� 5!   
   -   5         ��Name$ 
iconButton��5!      $��Odaberi ikonicu��6%   $
��Left=�6?   $��
152,13,0,0q�6Z   $��3��6n   $	��Top=�6{   $	��118��6�   6�   �� 5"   
   -	   5         ��Name$ isProcessedCheck��5"      $��Arheološki obrađen��6-   $��1��6J   $
��Left=�6Z   $��	10,18,0,0q�6u   $	��Top=�6�   $ 0.239,0&�6�   �� 5#   
   -
   5        $ isUnescoCheck��5#      $��Na UNESCO listi��6*   $��1��6D   $
��Left=�6T   $��	10,18,0,0q�6o   $	��Top=�6�   $ 0.239,0&�6�   $��1��6�   �� 5$   
   -   5        $ isInPopulatedCheck��5$      $��U naseljenoj oblasti��6/   $��1��6N   $
��Left=�6^   $��	10,18,0,0q�6y   $	��Top=�6�   $ 0.239,0&�6�   $��2��6�   �� 5%   
   -   5        $ label2_Copy��5%      $��Turistički status:��6%   $
��Left=�6B   $��	10,10,0,0q�6]   $��3��6p   $	��Top=�6}   $��1��6�   �� 5&   
   -   5        $ statusCombobox��5&      $
��Left=�6+   $��
104,13,0,0q�6F   $��3��6Z   $	��Top=�6g   $��82��6   $��1��6�   �� 5'   
   -   5        $ label_Copy1��5'      $��Godišnji prihod:��6%   $
��Left=�6@   $��10,9,0,0q�6[   $	��Top=�6m   $��4��6�   �� 5(   
   -   5        $��annualRevenueTextbox��5(   L   $��23��6   $
��Left=�6   $��	109,9,0,0q�69   $	��Top=�6h   $	��132��6�   $��4��6�   .��6�   ��5)      �� 5*       �� Path$ Prihod�6    �� UpdateSourceTrigger$ PropertyChanged=�6(    �� ValidationRules 5+      2   ,HCI.MonumentsProject.Presentation.Validacija  5,      ,  &System.Windows.Controls.ValidationRule   ValidationStep$ RawProposedValue=�6)   5.      .��5/       =� ErrorTemplate 50      �� 51      .R�52      �  53      �� 54       56      �� 57      �� 58      $
��Auto �6/   .+�5;      ��  ��Name$ textBox��6Q   $��0��64   $��0��6D   6Q   �� 5<      $��1��6$   $��0��64   
���  ����6A   �� *[0].ErrorContent+6c   5=      5>      .��5?   (   5@      �� 5A   
   -   5        $ label_Copy2��5A      $��	Otkriven:��6%   $
��Left=�69   $��10,9,0,0q�6T   $	��Top=�6f   $��4��6~   $��1��6�   �� 5B   
   -   5        $ createButton��5B      $��Kreiraj��6'   $��1��69   $
��Left=�6I   $��
205,32,0,0q�6d   $��5��6x   $	��Top=�6�   $	��113��6�   $��30��6�   6�   �� 5C   
   -   5        $ label_Copy3��5C      $
��Ime:��6%   $
��Left=�64   $��
148,10,0,0q�6O   $	��Top=�6c   $ 6.938,0.555&�6{   �� 5D   
   -   5        $	 nameTextbox��5D   M   $��23��6   $
��Left=�6   $��
189,15,0,0q�69   $	��Top=�6b   $��81��6z   .��6�    5E      �� 5F      .R�5G      �  5H      �� 5I       5K      �� 5L      �� 5M      $
��Auto �6/   .+�5P      �� $ textBox��6Q   $��0��64   $��0��6D   6Q   �� 5Q      $��1��6$   $��0��64   
���  ����6A   �� *[0].ErrorContent+6c   5R      5S      .��5T   (   .��5U      �� $	 Ime�6   $ PropertyChanged=�6!    5V      1   +HCI.MonumentsProject.Presentation.NeSmeBroj  5W      $ RawProposedValue=�6$   5Y      5Z      �� 5[   
   -   5        $ label1_Copy��5[      $
��Era:��6%   $
��Left=�64   $��
148,10,0,0q�6O   $��2��6c   $	��Top=�6p   �� 5\   
   -   5        $ monumentType��5\      $
��Left=�6)   $��	47,14,0,0q�6D   $��2��6W   $	��Top=�6d   $��81��6|   (  "System.Windows.Controls.DatePicker  5]   
   -   5          Name$ revealedDatePicker��5]      $
��Left=�61   $��	73,9,0,16q�6L   $	��115��6_   $��1��6k   $��4��6{   �� 5^   
   -   5         ��Name$ 	iconImage��5^      $
��Left=�6#   $��28��6>   $��	13,10,0,0q�6J   $��3��6]   $	��Top=�6j   5_      5`      