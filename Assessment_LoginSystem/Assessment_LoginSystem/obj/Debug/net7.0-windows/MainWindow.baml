   M S B A M L   `   `   `  ����Q  MAssessment_LoginSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Assessment_LoginSystemAssessment_LoginSystem  5   	   ]3clr-namespace:Assessment_LoginSystem.MVVM.ViewModel%Assessment_LoginSystem.MVVM.ViewModel  5   	   S.clr-namespace:Assessment_LoginSystem.MVVM.View Assessment_LoginSystem.MVVM.View  5   	   '    !Assessment_LoginSystem.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Assessment_LoginSystem     5   	   I	viewModel3clr-namespace:Assessment_LoginSystem.MVVM.ViewModel     5   	   ?view.clr-namespace:Assessment_LoginSystem.MVVM.View     5   	   $	��600��5
   	   $	��920��6     � WindowStyle$  SingleBorderWindow=�5   	    � 
ResizeMode$ NoResize=�5   	   ���#272537 � DataContext 5      9  3Assessment_LoginSystem.MVVM.ViewModel.MainViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5       � RowDefinitions 5   
   �� 5      $��75 �6   �� 5      .+�5   
   �� $��0��5      $��0��6   $��LogInner TM��5      $��Center=�5       $
��Left=�5!      
�������$��22(�5#      $��20,0,0,0q�5$      �� 5&   
   $��0��5'      $��1��6   $��
10,0,10,10q�5(      .+�5)      	� $
��Home��5*      $��50��5+      
�������$��14(�5-         MenuButtonTheme#��[  5.       d� 	IsChecked$
 TrueY�5/      ��50      �� *HomeViewCommand+	� 52      $��View User List��53      $��50��54      
�������$��14(�56      #��[  57      ��58      �� *UserListCommand+59      �� 5;   
   $��0��5<      $��1��6   $��
10,0,10,10q�5=      $��Bottom=�5>      .+�5@      �� -   5        $��LogoutButton��5G      $��Logout��5A      $��0,0,0,10q�5B      $��50��5C      
�������
���iii�$��14(�5F      5H      �� 5J      -   5        $��CloseButton��5P      $
��Exit��5K      $��50��5L      
�������$��14(�5N      
���  ��5Q      5R      �� 5T   
   $��1��5U      $��1��5V      $��
10,0,10,10q�5W      ��5X      �� *CurrentView+5Y      5Z      