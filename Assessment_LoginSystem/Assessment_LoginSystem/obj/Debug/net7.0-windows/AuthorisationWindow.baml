   M S B A M L   `   `   `  ����Q  MAssessment_LoginSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Assessment_LoginSystem.MVVM.View Assessment_LoginSystem.MVVM.View  5   	   ]3clr-namespace:Assessment_LoginSystem.MVVM.ViewModel%Assessment_LoginSystem.MVVM.ViewModel  5   	   0    *Assessment_LoginSystem.AuthorisationWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:Assessment_LoginSystem.MVVM.View     5   	   I	viewModel3clr-namespace:Assessment_LoginSystem.MVVM.ViewModel     5   	   -   5          �Name$  _this��5   	   ���#272537 � Title$ Login��5
   	   $	��500��6   $	��300��6$    � DataContext 5      B  <Assessment_LoginSystem.MVVM.ViewModel.AuthorisationViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��4* �6   �� 5      �� 5      .+�5   
   �� $��0��5      ��5      �� *CurrentView+�� 5   
   -   5        $��ToRegistration��5      $��1��5      $��Register new account��5      
����ح�
������ 
������ $��Right=�5!      $	��Top=�5"      $��0,0,10,0q�5#      ��5%      �� *RegisterViewCommand+�� 51   
   -   5        $��CloseButton��52      $��2��53      $��10q�54      $
��Exit��55      $��14(�56      
�������
���  ��59      �� 5H   
   -   5        $��
BackButton��5I      $��2��5J      $y�Hidden=�5K      $��10q�5L      $
��Back��5M      $��14(�5N      
�������
�����_���5R      �� *LoginViewCommand+5S      5T      