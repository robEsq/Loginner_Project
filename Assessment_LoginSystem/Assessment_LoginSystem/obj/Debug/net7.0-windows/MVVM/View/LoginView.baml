   M S B A M L   `   `   `  ����Q  MAssessment_LoginSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:Assessment_LoginSystem.MVVM.ViewModel%Assessment_LoginSystem.MVVM.ViewModel  5      S.clr-namespace:Assessment_LoginSystem.MVVM.View Assessment_LoginSystem.MVVM.View  5      0    *Assessment_LoginSystem.MVVM.View.LoginView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      I	viewModel3clr-namespace:Assessment_LoginSystem.MVVM.ViewModel     5      @local.clr-namespace:Assessment_LoginSystem.MVVM.View     5        � DataContext  5
      B  <Assessment_LoginSystem.MVVM.ViewModel.AuthorisationViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $	��.5* �6   �� 5      $	��.5* �6   �� 5      $
��1.5* �6   �� 5      $
��1.5* �6   �� 5      $	��.5* �6   �� 5      $��* �6   .+�5   
   �� $��0��5      $��Login��5      
�������$	��5,0q�5      $��16(�5      �� 5    
   -   5        $��authentication��5!      $��1��5"      $#��Invalid username or password!��5#      
���  ��$��14(�5%      $��Center=�5&      $��Center=�5'      $y�Hidden=�5(      �� 5+   
   $��2��6   .+�5,      �� $��Username��5-      $	��5,0q�5.      
�������$��14(�50      �� 51      -   5        $��username��52      $
��10,0q�53      $	��0,5q�54      55      �� 57   
   $��3��6   .+�58      �� $��Password��59      $	��5,0q�5:      
�������$��14(�5<      G� 5=      -   5        $��password��5>      $
��10,0q�5?      $	��0,5q�5@      5A      �� 5P   
   -   5        $��5��5Q      $��10q�5R      $��Login��5S      $��14(�5T      
�������
���iii�5W      5a      5b      