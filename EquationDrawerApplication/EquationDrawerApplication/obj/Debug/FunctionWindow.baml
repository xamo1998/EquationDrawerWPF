   M S B A M L   `   `   `  ����T  PEquationDrawerApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:EquationDrawerApplicationEquationDrawerApplication  5   	   o<clr-namespace:EquationDrawerApplication.ViewModels.Converter.EquationDrawerApplication.ViewModels.Converter  5   	   Q-clr-namespace:EquationDrawerApplication.ModelEquationDrawerApplication.Model  5   	   .    (EquationDrawerApplication.FunctionWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:EquationDrawerApplication     5   	   S
converters<clr-namespace:EquationDrawerApplication.ViewModels.Converter     5   	   ?model-clr-namespace:EquationDrawerApplication.Model     5   	   X TXceed.Wpf.Toolkit, Version=3.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5	   	   -   5          � Title$  FunctionWindow��5   	   $��244.709��6    $��575.417��61   ���	#FF1E1E1E � 	Resources 5      .   (EquationDrawerApplication.Model.Equation   EquationM   GEquationDrawerApplication.ViewModels.Converter.BackgroundColorConverter  	Converter��%:   &	        &	        5   
   6     5   
   6.   5      .��5      �  � DataContext 6   ��  �� Source# [   � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��10,10,10,10q�6   $��0��6%   $��0��65   $��Nombre: ��6B   �� 5   
   $��
0,10,20,10q�6   $��1��6&   $��0��66   ��6C   �� *Name+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5!   
   $��10,10,10,10q�6   $��Center=�6%   $��0��6B   $��1��6R   $��Color: ��6_   #  Xceed.Wpf.Toolkit.ColorPicker  5"   
   -   5        $��	0,10,0,10q�5"      $��1��6.   $	��100��6>   $
��Left=�6J   $��1��6e   ���	#FF3F3F46   SelectedColor 6�   �� *Color+$ TwoWay=�$ PropertyChanged=��� 5$   
   $��10,10,10,10q�6   $��Center=�6%   $��0��6B   $��2��6R   $��F(x): ��6_   �� 5%   
   $��
0,10,20,10q�6   $��1��6&   $��2��67   ��6D   �� *
Expression+$ TwoWay=�$ PropertyChanged=��� 5'   
   $��	0,10,0,10q�6   $��3��6$   $��2��61   $	��100��6E   $��20��6Q   $��Añadir��6]   	 �� 	IsDefault	 . ��5(      �� *addFunctionCommand+  ViewModelBase# [ ��5+      �� 5/      50      