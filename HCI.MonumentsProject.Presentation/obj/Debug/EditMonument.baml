   M S B A M L   `   `   `  ����\  XHCI.MonumentsProject.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:HCI.MonumentsProject.Presentation.HelpFiles+HCI.MonumentsProject.Presentation.HelpFiles  5   	   U/clr-namespace:HCI.MonumentsProject.Presentation!HCI.MonumentsProject.Presentation  5   	   4    .HCI.MonumentsProject.Presentation.EditMonument   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Gl9clr-namespace:HCI.MonumentsProject.Presentation.HelpFiles     5   	   Alocal/clr-namespace:HCI.MonumentsProject.Presentation     5   	     � Title$  Novi spomenik��5	   	   $	��342��6   $	��605��6,    � 
ResizeMode$ NoResize=�68   >   8HCI.MonumentsProject.Presentation.HelpFiles.HelpProvider   HelpKey$ index��6N    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Help��5      6<   .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $
��1.5* �6   .+�5   
   �� -   5         ��Name$ label��5      $
��Ime:��6   $
��Left=�6.   $��	154,9,0,0q�6I   $	��Top=�6\   �� 5   
   -   5         ��Name$ nameTextbox��5      $
��Left=�6'   $��23��6B   $��
191,13,0,0q�6N   	 �� TextWrapping$
	 Wrap=�6b   $	��Top=�6v   $��74��6�   �� 5   
   -   5        $ 
label_Copy��5      $��Opis:��6$   $
��Left=�64   $��	10,10,0,0q�6O   $	��Top=�6b   
 J� RenderTransformOrigin$
 0.969,4.308&�6z   $��1��6�   �� 5   
   -   5        $ descriptionTextbox��5      $
��Left=�6.   $��23��6I   $��	47,13,0,0q�6U   $��1��6h   $
	 Wrap=�6u   $	��Top=�6�   $	��139��6�   �� 5   
   -   5         ��Name$ eraDropdown��5      $
��Left=�6(   $��
191,14,0,0q�6C   $��2��6W   $	��Top=�6d   $��74��6|   �� 5   
   -   5        $ label1��5      $
��Era:��6    $
��Left=�6/   $��
154,10,0,0q�6J   $��2��6^   $	��Top=�6k   �� 5!   
   -   5         ��Name$ 
iconButton��5!      $��Odaberi ikonicu��6%   $
��Left=�6?   $��
154,13,0,0q�6Z   $��3��6n   $	��Top=�6{   $	��118��6�   6�   �� 5"   
   -	   5         ��Name$ isProcessedCheck��5"      $��Arheološki obrađen��6-   $��1��6J   $
��Left=�6Z   $��	10,18,0,0q�6u   $	��Top=�6�   $
 0.239,0&�6�   �� 5#   
   -
   5        $ isUnescoCheck��5#      $��Na UNESCO listi��6*   $��1��6D   $
��Left=�6T   $��	10,18,0,0q�6o   $	��Top=�6�   $
 0.239,0&�6�   $��1��6�   �� 5$   
   -   5        $ isInPopulatedCheck��5$      $��U naseljenoj oblasti��6/   $��1��6N   $
��Left=�6^   $��	10,18,0,0q�6y   $	��Top=�6�   $
 0.239,0&�6�   $��2��6�   �� 5%   
   -   5        $ label2_Copy��5%      $��Turistički status:��6%   $
��Left=�6B   $��	10,10,0,0q�6]   $��3��6p   $	��Top=�6}   $��1��6�   �� 5&   
   -   5        $ touristDropdown��5&      $
��Left=�6,   $��
104,13,0,0q�6G   $��3��6[   $	��Top=�6h   $��82��6�   $��1��6�   �� 5'   
   -   5        $ label_Copy1��5'      $��Godišnji prihod:��6%   $
��Left=�6@   $��10,9,0,0q�6[   $	��Top=�6m   $��4��6�   �� 5(   
   -   5        $ revenueTextbox��5(      $
��Left=�6*   $��23��6E   $��
109,13,0,0q�6Q   $
	 Wrap=�6e   $	��Top=�6y   $��77��6�   $��4��6�   �� 5)   
   -   5        $ label_Copy2��5)      $��	Otkriven:��6%   $
��Left=�69   $��10,9,0,0q�6T   $	��Top=�6f   $��4��6~   $��1��6�   (  "System.Windows.Controls.DatePicker  5+   
   -   5        $��revealedDatePicker��5+      $
��Left=�6/   $��
73,12,0,14q�6J   $	��115��6^   $��1��6j   $��4��6z   �� 5-   
   -   5        $ updateButon��5-      $��	Ažuriraj��6&   $��1��69   $
��Left=�6I   $��
174,32,0,0q�6d   $��5��6x   $	��Top=�6�   $	��113��6�   $��30��6�   6�   �� 5.   
   -   5        $ label_Copy3��5.      $	��Id:��6%   $
��Left=�63   $��13,9,0,0q�6N   $	��Top=�6`   �� 5/   
   -   5        $ 	idTextbox��5/      $
��Left=�6%   $��23��6@   $��	47,13,0,0q�6L   $
	 Wrap=�6_   $	��Top=�6s   $��74��6�   �� 50   
   -   5        $ typeDropdown��50      $
��Left=�6)   $��	47,14,0,0q�6D   $��2��6W   $	��Top=�6d   $��74��6|   �� 51   
   -   5        $ label1_Copy��51      $
��Tip:��6%   $
��Left=�64   $��	10,10,0,0q�6O   $��2��6b   $	��Top=�6o   �� 52   
   -   5         ��Name$ 	iconImage��52      $
��Left=�6#   $��28��6>   $��	13,10,0,0q�6J   $��3��6]   $	��Top=�6j   54      55      