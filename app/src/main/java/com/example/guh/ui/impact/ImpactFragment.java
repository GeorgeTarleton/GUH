package com.example.guh.ui.impact;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.Nullable;
import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.lifecycle.Observer;
import androidx.lifecycle.ViewModelProviders;

import com.example.guh.R;

public class ImpactFragment extends Fragment {

    private ImpactViewModel impactViewModel;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {
        impactViewModel =
                ViewModelProviders.of(this).get(ImpactViewModel.class);
        View root = inflater.inflate(R.layout.fragment_impact, container, false);
        final TextView textView = root.findViewById(R.id.text_impact);
        impactViewModel.getText().observe(this, new Observer<String>() {
            @Override
            public void onChanged(@Nullable String s) {
                textView.setText(s);
            }
        });
        return root;
    }
}