   M S B A M L   `   `   `  ����T  PEquationDrawerApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:EquationDrawerApplicationEquationDrawerApplication  5   	   Q-clr-namespace:EquationDrawerApplication.ModelEquationDrawerApplication.Model  5   	   S.clr-namespace:EquationDrawerApplication.Models EquationDrawerApplication.Models  5   	   o<clr-namespace:EquationDrawerApplication.ViewModels.Converter.EquationDrawerApplication.ViewModels.Converter  5
   	   1    +EquationDrawerApplication.PersonalizeWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:EquationDrawerApplication     5   	   C	equations-clr-namespace:EquationDrawerApplication.Model     5   	   @model.clr-namespace:EquationDrawerApplication.Models     5   	   X TXceed.Wpf.Toolkit, Version=3.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5	   	   L	Converter<clr-namespace:EquationDrawerApplication.ViewModels.Converter  5
   	   -   5          � Title$  PersonalizeWindow��5   	   $��539.1��6#   $��753.5��62   ���	#FF1E1E1E � 	Resources 5      M   GEquationDrawerApplication.ViewModels.Converter.BackgroundColorConverter   BackgroundColorConverter.   (EquationDrawerApplication.Model.Equation  Equation��%:   &	        &	        5   
   6-     5   
   6   5      .��5      �  � DataContext 6   ��  �� Source# [  � RowDefinitions 5   
   �� 5      $
��1.5* �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��1.5* �6   .+�5    
   �� -   5         ��Name$ equationsPersonalizeTable��5    e    �� SelectionMode$ Single=�6B   $��10q�6Y   ���	#FF252323���	#FFB4B4B4��6�   ��  �� Mode$ OneWay=�  ViewModelBase# [ ��5"      �� 5$      .R�5%      � $	��240��6    5&      �� 5'      $��* �6/   �� 5(      $��* �6/   �� 5)      $��* �6/   .+�5,      �� $��0��6$   ��64   �� *Name+�� 5-      $��1��6$   $��0,0,0,0q�6P   ��64   �� *
Expression+6P   �� 5.      $��2��6$   $��0,0,0,0q�6�   ��65   �� *Color+	 �� 	Converter#	 [  6�   51      52      5A      � 5B   
   $��2��6    5C      �� 5D      $
��auto �6#   �� 5E       5G      �� 5H      $
��auto �6    �� 5I      $
��auto �6    �� 5J      $
��auto �6    �� 5K      $
��auto �6    .+�5N      �� $��Ancho de traza:��6   $��10,30,10,10q�6.   $��Center=�6C   �� 5O      -   5        $��sliderFunction��5O   '   {�.  
 � Minimum$
 1Q�6=    � Maximum$ 5Q�6I   $��1��6|   $��Center=�6�   $��0,0,20,0q�6�    � Cursor$
 Hand��6�    � Value 6�   ��  �� ElementName$ equationsPersonalizeTable�� �� Path$- 'SelectedItem.(equations:Equation.Width)�$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5Q      $��Color: ��6   $��1��6&   $��10,10,10,10q�64   $��Center=�6I   #  Xceed.Wpf.Toolkit.ColorPicker  5R      -   5        $��colorPickerFunction��5R   1   {�.  $��	0,10,0,10q�6y   $��1��6+  $	��100��6;  $
��Left=�6G  $��1��6b  ���	#FF3F3F46   SelectedColor 6�   �� $ equationsPersonalizeTable��$- 'SelectedItem.(equations:Equation.Color)�$ TwoWay=�$ PropertyChanged=�6o  �� 5T      $��Nombre: ��6   $��2��6'   $��10,10,10,10q�65   $��Center=�6J   �� 5U      -   5        $��textBoxName��5U   (   {�.  $��1��6;   $��2��6�   $��
0,10,20,10q�6�   ��6K   �� $ equationsPersonalizeTable��$, &SelectedItem.(equations:Equation.Name)�$ TwoWay=�$ PropertyChanged=�6�   5X      �� 5Y   
   $��1��6   $��3��6!   $��5,0,5,0q�65   �� 5Z   
   $��1��6   $��1��6$   $��3��61   $��0,5,0,5q�6B    � LayoutTransform 5[      �� 5\       �� Angle$ 90Q�6"   5^      � 5_   
   $��2��6    5`      �� 5a      $
��auto �6#   �� 5b      $
��auto �6#   �� 5c      $
��auto �6#    5e      �� 5f      $
��auto �6    �� 5g      $
��auto �6    �� 5h      $
��auto �6    �� 5i      $
��auto �6    �� 5j      $
��auto �6    .+�5l      �� $��Color fondo: ��6   $��0,10,0,0q�6,     5m      $��1��6   $	��100��6/   $
��Left=�6;   ���	#FF3F3F46$��0,10,0,0q�6m    6   �� *BackgroundColor+ 	 model# [ $ TwoWay=�$ PropertyChanged=��� 5n      -   5        $��0��5n      $��1��6'   $
��Ejes��64   $��	10,10,0,0q�6C    d� 	IsChecked 6V   �� *Axis+# [ 6�   �� 5o      -   5        $��0��5o      $��2��6'   $
��Grid��64   $��	10,10,0,0q�6C    6V   �� *Grid+# [ 6�   �� 5p      -   5        $��0��5p      $��3��6'   $��Ticks��64   $��	10,10,0,0q�6D    6W   �� *Tick+# [ 6�   �� 5q      -	   5        $��0��5q      $��4��6'   $��Numeros��64   $��	10,10,0,0q�6F    6Y   �� *	Numbers+# [ 6�   5t      � 5v   
   $��2��6   $��2��6   $��Center=�6,    5w      �� 5x      $
��auto �6#   �� 5y      $
��auto �6#   �� 5z      $
��auto �6#    5|      �� 5}      $
��auto �6    �� 5~      $
��auto �6    �� 5      $
��auto �6    .+�5�      �� $��Dominio y Recorrido��6   $��Center=�63   $��3��6P   $��0,10,0,0q�6d   �� 5�      -
   5        $��1��5�      $	��100��6#   $��5q�6/   ��6`   �� *MinX+# [ $ TwoWay=�$ PropertyChanged=��� 5�      $��< x <��6   $��1��6*   $��1��6:   $��Center=�6G   $��5q�6d   �� 5�      -   5        $��1��5�      $��2��6#   $	��100��63   $��5q�6e   ��6p   �� *MaxX+# [ $ TwoWay=�$ PropertyChanged=��� 5�      -   5        $��2��5�      $	��100��6#   $��5q�6/   ��6`   �� *MinY+ �� NotifyOnTargetUpdated .  �� NotifyOnSourceUpdated . $ TwoWay=�# [ $ PropertyChanged=��� 5�      $��< y <��6   $��1��6*   $��2��6:   $��Center=�6G   $��5q�6d   �� 5�      -   5        $��2��5�      $��2��6#   $	��100��63   $��5q�6e   ��6p   �� *MaxY+# [ $ TwoWay=�$ PropertyChanged=�5�      5�      5�      